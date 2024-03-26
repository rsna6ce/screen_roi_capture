@echo off
set MSBUILD_PATH=C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe
set SOLUTION_FILE=screen_roi_capture.sln
set BUILD_CONFIG=release
set BUILD_TYPE=rebuild

call :rewrite_file "screen_roi_capture\Form1.resx"
call :rewrite_file "screen_roi_capture\Properties\Resources.resx"
call :rewrite_file "screen_roi_capture\screen_roi_capture.csproj"

if not exist "%MSBUILD_PATH%" (
    echo �G���[:MSBuild�����݂��܂���
    exit /b 0
)

if not exist "%SOLUTION_FILE%" (
    echo �G���[:�\�����[�V�����t�@�C�������݂��܂���
    exit /b 0
)

if not "%BUILD_CONFIG%"=="debug" if not "%BUILD_CONFIG%"=="release" (
    echo �G���[:�r���h�\�����s���ł�
    exit /b 0
)

if not "%BUILD_TYPE%"=="build" if not "%BUILD_TYPE%"=="rebuild" (
    echo �G���[:�r���h��ނ��s���ł�
    exit /b 0
)

%MSBUILD_PATH% %SOLUTION_FILE% /p:Configuration=%BUILD_CONFIG% /t:%BUILD_TYPE% /m

@echo �r���h���������܂���
pause
exit 0

:rewrite_file
    if exist %1 (
        type %1 > "%12"
        copy "%12" "%1"
        del "%12"
    )