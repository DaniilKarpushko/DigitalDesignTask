/*
 * Use -ff {fileName} {filename} - to execute command fo counting words in file
 * Use -e - to end program
 * Using pattern Strategy in future
 * we can also add counting words not only in files but in other objects
 * And for adding new parameters I use CoR pattern
 */

using Microsoft.Extensions.DependencyInjection;
using WordCounter;


var sv = new ServiceCollection();
var app = new Startup(sv);
app.Configure();
app.Run();

