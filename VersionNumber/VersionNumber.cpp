// VersionNumber.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <windows.h>
#include "windef.h"
#define VERSION "3.3.12"

extern "C"
{
  __declspec(dllexport) char* WINAPI GetMyVersion() {
    return (char*)VERSION;
  }
}

