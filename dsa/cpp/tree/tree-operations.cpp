#include <iostream>
using namespace std;

#define LEFT 1
#define RIGHT 2

void drawline(int n);
void messagebox(string message);

class Node
{
    int data;
    Node *left;
    Node *right;

public:
    Node(int data)
    {
        this->data = data;
        left = NULL;
        right = NULL;
    }

    void setData(int data)
    {
        this->data = data;
    }

    int getData()
    {
        return data;
    }

    void setLeft(Node *left)
    {
        this->left = left;
    }

    Node *getLeft()
    {
        return left;
    }

    void setRight(Node *right)
    {
        this->right = right;
    }

    Node *getRight()
    {
        return right;
    } 
};

class Tree
{
    Node *root = NULL;

public:
    Node* getRoot()
    {
        return root;
    }

    // void displayTreePreOrder(Node *node);
    void addRootNode(int data);
    void addLeftNode(int data);
    void addRightNode(int data);
};

void displayTreePreOrder(Node *node)
{
    if(node == NULL)
        return;

    displayTreePreOrder(node->getLeft());
    displayTreePreOrder(node->getRight());
    cout << node->getData() << " ";
}

void Tree::addRootNode(int data)
{
    root = new Node(data);
    messagebox("Root node created!");
}

void Tree::addLeftNode(int data)
{
    root->setLeft(new Node(data));
    messagebox("Node created!");
}

void Tree::addRightNode(int data)
{
    root->setRight(new Node(data));
    messagebox("Node created!");
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

int main(void)
{
    Tree tree;
    displayTreePreOrder(tree.getRoot());
    tree.addRootNode(10);
    displayTreePreOrder(tree.getRoot());
    tree.addLeftNode(20);
    displayTreePreOrder(tree.getRoot());
    tree.addRightNode(30);
    displayTreePreOrder(tree.getRoot());
}