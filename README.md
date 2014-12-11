ScriptCs.Shebang
================

[Shebang](http://en.wikipedia.org/wiki/Shebang_(Unix)) support for [ScriptCs](http://scriptcs.net/)

This will be useful for scripting with [ScriptCs](http://scriptcs.net/) on *nix systems.

Installation
------------
1. Install [Mono](http://www.mono-project.com/download/)
2. Install [ScriptCs](http://scriptcs.net/) for *nix systems: [guide](https://github.com/scriptcs/scriptcs/wiki/Installing-on-Mac-and-Linux)
3. Create files in /usr/bin (or any other directory in your PATH) with this content:

  **scriptcs**
  ```bash
  #!/bin/sh
  
  sciptcs_exe=<path to sciptcs.exe>
  
  mono ${scriptcs_exe} $*
  ```
  
  **scriptcs_sh**
  ```bash
  #!/bin/bash
  scriptcs $1 -- ${*:1}
  ```

4. Make this files executable: 
  ```sh
  # In directory with scripts from above
  chmod +x scriptcs
  chmod +x scriptcs_sh
  ```
5. Install ScriptCs.Shebang module globally:
  ```sh
  scriptcs -i ScriptCs.ShebangModule -g
  ```

6. Write example script:
  **test.csx**
  ```csharp
  #!/usr/bin/env scriptcs_sh
  
  Console.WriteLine("Hello world");
  ```
  
7. Make script executable:
  ```sh
  chmod +x test.csx
  ```
8. Now you can exec ScriptCs scripts just like any shell scripts. Enjoy!
