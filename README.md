This is an executable version of Abstract Dynamic Slicer for testing purposes.
The executable is on .\slicer\SliceBrowser.exe

You will find a lot of parameters to set, for the moment you can start opening ./example/config/default.slc and try to run the slicer for the project located in ./example/src/example_project.sln. The default criterion is line 28.

If you executed the default.slc file, then you can reload the result opening load_results.slc.

Parameters of the slicer:

Solutions:
- User's solution is the client source code
- Executable project is the name of the project to run
- Compilation output folder is where the slicer will save the instrumented solution
- If you uncheck the instrument and compile option, you have to specify the instrumented solution path. For example, if you instrument the solution once you don't need to instrument again if you didn't change anything. 

Mode | Criteria:
- Mode: 
* Normal: you have to specify the criteria
* No break: you don't have to specify the criteria, the slicer will analyse completely the trace
* Load Results: you only have to specify previous result files
- File and line are for specifying the criterion
- File trace input enabled means that the instrumentation will produce the trace and then consume it. By the other way, the slicer can consume the trace on the fly (without saving the trace file first)
- Load file trace input is when you ran the instrumented program outside the slicer environment and you want to use that trace file
- Run automatically is enabled by default. If you want to run the program by yourself the slicer will wait for you
- Not compile is when you want to avoid the compilation from the slicer, and you prefer to compile (and then execute) the program by yourself

Slice customization:
- Summaries is the file where you can specify the behavior of the slicer on no instrumented methods calls. We will add more information as soon as possible, feel free to open the file ./data/summaries.xml for take a look at how it works in different scenarios
- Include control dependencies is optional in our slicer, you can uncheck this option if you want to slice only data dependencies
- Include all uses is complex to explain:
Suppose you have "x = a.b.c;". The "last definition point" could be only the last assignment of "c" or it could include the last assignments of "a", "b", and "c". If you check "include all uses" the last definition point of these kinds of assignments will include all the intermediate fields last definition. This is useful when you try to compile the slice result, but not for debugging (for example).
- PTG Compression is used for compress the points-to graph (adding imprecision)
- Loops Optimization doesn't introduce more imprecision than PTG Compression. So if you check the last option, we recommend you check this option too

Program inputs:
- Here you can specify the inputs for executing the client program

Results:
- Program's name is used to create a folder with that name where the results will be allocated
- Main output folder is where the slicer will create the results folder
- Summary is where the main running results will be writen (timing, #LoC,...)
- Executed lines (user) is where you can find which lines were executed in the format "FileName:Line"
- Executed lines is where you can find which parts of lines were executed in slicer format like "FileId:[SpanStart-SpanEnd]"
- Results file is for saving the slice result in the format "FileName:Line"
- Results file (filtered) is the same as Results File but removing field declarations and method headers

Dependency graph information:
- Slices graph folder is where the slicer will save: a) the dependency graph of the slice in slicer format, and b) a DGML file: this is a graph extension for VS
- Dependency graph full is the complete DG
- Dependency graph plot is for the DOT/DGML file

Points-to information:
- Points-to graph plot, we will save a DOT file and DGML file. In this case and in the last one, you have to specify the DOT file location and we will save the DOT file and DGML file also
- Print PTG for each statement is when you want to see what happen in our PTG printing it in each statement. The files will be located in the same place as the summary file. This is so expensive, please avoid this configuration as much as possible