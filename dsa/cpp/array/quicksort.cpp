#include <iostream>
using namespace std;

void display(int arr[], int size);
int* quickSort(int arr[], int size);

int main()
{
    int arr[100] = {86, 52, 49, 99, 12, 26};
    int size = 6;
    
    cout << "Array content before sorting:" << endl;
    display(arr, size);

    quickSort(arr, size);
    
}

void display(int arr[], int size)
{
    for(int i=0; i<size; i++)
        cout << arr[i] << endl;
}

int* quickSort(int arr[], int size)
{
    if(size < 2)
        return arr;
}