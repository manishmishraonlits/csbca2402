#include <iostream>
#include <cstdlib>

#define MAX 100
#define EMPTY 0
#define ASC 0
#define DSC 1

using namespace std;

void drawline(int n);
void messagebox(string message);
void display(int arr[], int const size);
void insert(int arr[], int *size, int value, int index);
void remove(int arr[], int *size, int index);
int linearSearch(int arr[], int const size, int const key);
int binarySearch(int arr[], int const size, int const key);
void selectionSort(int arr[], int const size, int order = ASC);

int main(void)
{
    int arr[MAX], size = EMPTY, value, index = -1, key;
    int response;
    while (1)
    {
        cout << "MAIN MENU - Array Operations" << endl;
        drawline(50);
        cout << "1. Display (Traversal)" << endl;
        cout << "2. Insert" << endl;
        cout << "3. Delete" << endl;
        cout << "4. Linear Search" << endl;
        cout << "5. Binary Search" << endl;
        cout << "6. Selection Sort" << endl;
        cout << "Enter choice [0 to exit]: ";
        cin >> response;
        switch (response)
        {
        case 0:
            cout << "Bye!";
            exit(0);
            break;
        case 1:
            display(arr, size);
            break;
        case 2:
            cout << endl
                 << "Enter value: ";
            cin >> value;
            cout << "Enter index: ";
            cin >> index;
            insert(arr, &size, value, index);
            break;
        case 3:
            cout << endl
                 << "Enter index: ";
            cin >> index;
            remove(arr, &size, index);
            break;
        case 4:
            cout << endl
                 << "Enter the value to search: ";
            cin >> key;
            index = linearSearch(arr, size, key);
            if (index == -1)
                messagebox("Value not found!");
            else
                printf("\n%d found at %d.\n\n", key, index);
            break;
        case 5:
            cout << endl
                 << "Enter the value to search: ";
            cin >> key;
            index = linearSearch(arr, size, key);
            if (index == -1)
                messagebox("Value not found!");
            else
                printf("\n%d found at %d.\n\n", key, index);
            break;
        case 6:
            selectionSort(arr, size);
            break;
        default:
            messagebox("Invalid Option!");
            break;
        }
    }
}

void drawline(int n)
{
    for (int i = 1; i <= n; i++)
        cout << "-";

    cout << endl;
}

void messagebox(string message)
{
    cout << endl;
    drawline(message.length());
    cout << message << endl;
    drawline(message.length());
    cout << endl;
}

void display(int arr[], int const size)
{
    if (size == EMPTY)
    {
        messagebox("Array Empty!");
        return;
    }

    cout << endl
         << "The array contains following values:" << endl;

    const int linesize = 10;
    drawline(linesize);
    for (int i = 0; i < size; i++)
    {
        cout << arr[i] << endl;
    }
    drawline(linesize);
}

void insert(int arr[], int *size, int value, int index)
{
    if (*size == MAX)
    {
        messagebox("Array overflow!");
        return;
    }

    if (index > *size)
    {
        messagebox("Invalid index!");
        return;
    }

    for (int i = *size; i > index; i--)
    {
        arr[i] = arr[i - 1];
    }

    arr[index] = value;
    (*size)++;

    messagebox("Value inserted!");
}

void remove(int arr[], int *size, int index)
{
    if (size == EMPTY)
    {
        messagebox("Array Empty!");
        return;
    }

    if (index >= *size)
    {
        messagebox("Invalid index!");
        return;
    }

    for (int i = index; i < *size; i++)
    {
        arr[i] = arr[i + 1];
    }

    (*size)--;

    messagebox("Value deleted!");
}

int linearSearch(int arr[], int const size, int const key)
{
    for (int i = 0; i < size; i++)
    {
        if (arr[i] == key)
        {
            return i;
        }
    }
    return -1;
}

int binarySearch(int arr[], int const size, int const key)
{
    int low = 0, high = size - 1, mid;
    while (low <= high)
    {
        mid = (low + high) / 2;
        if (arr[mid] == key)
        {
            return mid;
        }
    }
    return -1;
}

void selectionSort(int arr[], int const size, int order)
{
    for(int i=0; i<size-1; i++)
    {
        for(int j=i+1; j<size; j++)
        {
            if(arr[i] > arr[j])
            {
                int t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
            }
        }
    }
    messagebox("Array sorted!");
}