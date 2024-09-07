#include <iostream>

using namespace std;

void drawline(int n);
void messagebox(string message);

namespace linkedlist
{
    class Node
    {
        int data;   // instance variable
        Node *next; // "
    public:
        Node() {}
        Node(int data) // Parameterized constructor
        {
            this->data = data;
            next = NULL;
        }

        void setData(int data)
        {
            this->data = data;
        }

        int getData()
        {
            return data;
        }

        void setNext()
        {

        }

        Node* getNext()
        {
            return next;
        }
    };

    class LinkedList
    {
        Node *head = NULL;

    public:
        void display();
    };

    void LinkedList::display()
    {
        if (head == NULL)
        {
            messagebox("List is empty!");
            return;
        }

        head = new Node();

        while (head->getNext() != NULL)
        {
            cout << head->getData() << endl;
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

int main(int argc, char const *argv[])
{
    int response;
    linkedlist::LinkedList list;
    while (1)
    {
        cout << "MAIN MENU" << endl;
        cout << "1. Display (Traversal)" << endl;
        cout << "Enter choice [0 to exit]: ";
        cin >> response;
        switch (response)
        {
        case 0:

            exit(0);
            break;
        case 1:
            list.display();
            break;
        default:
            break;
        }
    }
}
