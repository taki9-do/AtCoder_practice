#include <iostream>
#include<vector>

using namespace std;

#define ll long long

int main(void) {
    // Your code here!
    int N;
    cin >> N;

    vector<ll> S(N), T(N);

    for (int i = 0;i < N;i++) cin >> S[i];

    for (int i = 0;i < N;i++) cin >> T[i];

    vector<ll> Recieve_T = T;

    for (int i = 0;i < N*2;i++) {
        Recieve_T[(i + 1) % N] = min(Recieve_T[(i + 1) % N], Recieve_T[i % N] + S[i % N]);
    }

    for (int i = 0;i < N;i++) cout << Recieve_T[i] << endl;


}
