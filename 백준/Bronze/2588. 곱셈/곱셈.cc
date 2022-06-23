#include <iostream>
#include <string>

using namespace std;

int main()
{
    int A, B;
    string strB;

    cin >> A >> B;

    strB = to_string(B);
    int b1 = strB[0] - '0';
    int b2 = strB[1] - '0';
    int b3 = strB[2] - '0';


    cout << A * b3 << endl;
    cout << A * b2 << endl;
    cout << A * b1 << endl;
    cout << A * B;

    return 0;
}