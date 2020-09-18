#include <iostream>
#include <cstring>

int main() {
    char str[] = "hello";

    std::cout << str << std::endl;

    int size = strlen(str);
    for (int i = 0; i < size / 2; i+=2) {
        char temp = str[i];
        str[i] = str[i+1];
        str[i+1]=temp;
    }

    std::cout << str << std::endl;
    return 0;
}
