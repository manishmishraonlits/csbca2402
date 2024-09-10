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
        Node(int data, Node *next)
        {
            this->data = data;
            this->next = next;
        }

        void setData(int data)
        {
            this->data = data;
        }

        int getData()
        {
            return data;
        }

        void setNext(Node *next)
        {
            this->next = next;
        }

        Node *getNext()
        {
            return next;
        }
    };

    class LinkedList
    {
        Node *head = NULL;

    public:
        void display();
        void append(int data);
        void insert(int data);
        void insert(int index, int data);
    };

    void LinkedList::display()
    {
        if (head == NULL)
        {
            messagebox("List is empty!");
            return;
        }

        Node *cursor = head;

        cout << endl
             << "The content of the list is as follows: " << endl;
        drawline(10);
        while (1)
        {
            cout << cursor->getData() << endl;
            if (cursor->getNext() == NULL)
                break;
            cursor = cursor->getNext();
        }
        drawline(10);
        cout << endl;
    }

    void LinkedList::append(int data)
    {
        if (head == NULL)
        {
            head = new Node(data);
            return;
        }

        Node *cursor = head;

        while (cursor->getNext() != NULL)
            cursor = cursor->getNext();

        cursor->setNext(new Node(data));
    }

    void LinkedList::insert(int data)
    {
        if (head == NULL)
        {
            head = new Node(data);
            return;
        }
        head = new Node(data, head);
    }

    void LinkedList::insert(int index, int data)
    {
        if (head == NULL)
        {
            head = new Node(data);
            return;
        }

        Node *cursor = head;
        for (int i = 1; i < index; i++)
        {
            cursor = cursor->getNext();
        }

        cursor->setNext(new Node(data, cursor->getNext()));
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
    int response, data, index;
    linkedlist::LinkedList list;
    while (1)
    {
        cout << "MAIN MENU" << endl;
        cout << "1. Display (Traversal)" << endl;
        cout << "2. Append" << endl;
        cout << "3. Insert (at the beginning)" << endl;
        cout << "4. Insert at an index" << endl;
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
        case 2:
            cout << endl
                 << "Enter a value: ";
            cin >> data;
            list.append(data);
            messagebox("Value inserted!");
            break;
        case 3:
            cout << endl
                 << "Enter a value: ";
            cin >> data;
            list.insert(data);
            messagebox("Value inserted!");
            break;
        case 4:
            cout << endl
                 << "Enter a value: ";
            cin >> data;
            cout << "Enter index: ";
            cin >> index;
            list.insert(index, data);
            messagebox("Value inserted!");
            break;
        default:
            messagebox("Invalid option!");
            break;
        }
    }
}
