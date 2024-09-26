#include <iostream>

using namespace std;

int factorial(int n);

int main(void)
{
    int n;
    cout << "Enter a number: ";
    cin >> n;

    cout << "Factorial is: " << factorial(n);

    return 0;
}

int factorial(int n)
{
    if (n <= 1) // base case
        return 1;

    return n * factorial(n - 1); // recursive case
}