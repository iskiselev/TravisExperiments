@echo off
SET PATH=%~dp0;%PATH%
SET npm_config_git=%~dp0git.cmd
"%~dp0node" "%~dp0..\packages\Npm.1.4.15.2\node_modules\npm\bin\npm-cli.js" %*
