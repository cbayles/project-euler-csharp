require './watcher_dot_net.rb'

#edit the code below to pick your builder and runner, 
#for :builder you can use either :MSBuilder, or :RakeBuilder
#for :test_runner you can use :NSpecRunner, :NUnitRunner, or :MSTestRunner
@dw = WatcherDotNet.new ".", { :builder => :RakeBuilder, :test_runner => :NSpecRunner }

#if you choose :NSpecRunner as your :test_runner,
#this is the execution path for the NSpecRunner, the recommendation is that you install nspec via nuget: Install-Package nspec
#if you do install from nuget, specwatchr will automatically find the file.
#if you want to explicitly set the execution path for nspecrunner.exe, uncomment the line below
#NSpecRunner.nspec_path = './packages/NSpec-0.9.58/NSpecRunner.exe'

#if you choose :RakeBuilder as your :builder
#this is the rake command that will get executed
RakeBuilder.rake_command = 'rake'

#all notifications are facilitated through Growl for Windows
#set to empty string if you dont have growl installed
GrowlNotifier.growl_path = ''

#specwathcr tries to automatically find your test dlls (it'll look for projects that end in the word Test, Tests, Spec or Specs)
#if for some reason you deviate from this convention, you can OVERRIDE the dlls selected using the following line of code
#@dw.test_runner.test_dlls = ['.\NSpecSpecs\bin\Debug\NSpecSpecs.dll']




#everything after this is specwatchr specific, you dont have to worry about this stuff
def handle filename
	@dw.consider filename
end

def reload file
  @dw.notifier.execute "reloading", "Reloading SpecWatchr because #{file} changed.", "green"
  FileUtils.touch "dotnet.watchr.rb"
end

def tutorial
  puts "======================== SpecWatcher has started ==========================\n\n"
  puts "TEST RUNNER: #{@dw.test_runner.class}\n\n"
  puts "(you can change your test runner in dotnet.watchr.rb...)\n\n"

  if(@dw.test_runner.test_dlls.count == 0)
    puts "WARNING WARNING WARNING"
    puts "I didn't find any test projects.  Test projects MUST end in the word Test or Tests.  For example: UnitTests.csproj"
    puts "If you have these projects, try building your solution and re-running SpecWatchr\n\n"
  else
    puts "I have found the following test dll's in your solution:"
    @dw.test_runner.test_dlls.each { |dll| puts dll }
  end

  puts "\n\n"

  if(GrowlNotifier.growl_path)
    puts "GROWL PATH: #{GrowlNotifier.growl_path}"
    puts "If you do not have Growl For Windows installed, open up dotnet.watchr.rb and set GrowlNotifier.growl_path to \"\" (empty string)"
  end

  puts "\n\n"

  puts "USAGE INSTRUCTIONS FOR #{@dw.test_runner.class}"
  puts @dw.test_runner.usage
end

tutorial

watch ('.*.cs$') { |md| handle md[0] }
watch ('(.*.csproj$)|(.*.sln$)') do |md| 
  reload md[0]
end
