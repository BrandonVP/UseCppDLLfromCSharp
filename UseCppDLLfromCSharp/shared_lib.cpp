#include "shared_lib.h"

int add(int a, int b)
{
    int bn = add2();
    return bn;
}

int add2()
{
    return 10;
}

void SaySomething(const char *str)
{
    std::cout << "I typed:" << str << endl;
}