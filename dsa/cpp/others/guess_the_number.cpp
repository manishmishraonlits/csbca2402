#include <iostream>
using namespace std;

namespace games
{
    class guess_the_number
    {
    public:
        void start(int low, int high)
        {
            int mid, i = 0, cheater = 1;
            char response;
            printf("Guess a number between %d and %d and press enter when ready!", low, high);
            getchar();
            while (low <= high)
            {
                i++;
                mid = (low + high) / 2;
                printf("Is the number %d ([y]/[n])? ", mid);
                cin >> response;
                if (response == 'y')
                {
                    printf("Wow! I guessed your number in %d attempt(s).\n", i);
                    cheater = 0;
                    break;
                }
                else
                {
                    printf("Is %d too high ([y]/[n])? ", mid);
                    cin >> response;
                    if (response == 'y')
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
            }
            if (cheater == 1)
            {
                cout << "It seem you are trying to cheat!" << endl;
            }
        }
    };
}

int main(int argc, char const *argv[])
{
    games::guess_the_number g;
    g.start(1, 100);
    return 0;
}