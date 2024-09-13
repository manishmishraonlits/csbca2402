#include <iostream>
using namespace std;

#define LEFT 1
#define RIGHT 2

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
};

class Tree
{
    Node *root = NULL;

public:
    void displayTreePreOrder();
    void addNode(int data, Node *parent = NULL, int pos = LEFT);
};

void Tree::displayTreePreOrder()
{
    if(root == NULL)
    {
        cout << endl << "Tree empty!" << endl;
        return;
    }

    cout << root->data << endl;
}

void Tree::addNode(int data, Node *parent, int pos)
{
    if (root == NULL)
    {
        root = new Node(data);
    }
}

int main(void)
{
    Tree tree;
    // tree.addNode(data, parent, pos);
}