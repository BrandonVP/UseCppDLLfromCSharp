#ifndef SHARED_LIB_h
#define SHARED_LIB_h

#include <string>
#include <iostream>
#include <cstdlib>
#include <cstdio>
#include <cstring>
#include <array>

using namespace std;

#ifdef __cplusplus
    extern "C" {
#endif

#ifdef BUILD_MY_DLL
    #define SHARED_LIB __declspec(dllexport)
#else
    #define SHARED_LIB __declspec(dllimport)
#endif

int SHARED_LIB add(int a, int b);
int SHARED_LIB add2();
void SHARED_LIB SaySomething(const char *str);

#ifdef __cplusplus

    }
#endif
#endif