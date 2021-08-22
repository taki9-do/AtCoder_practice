// 210821_001.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

#include <iostream>
#include <vector>

#define ll long long
using namespace std;

bool solve(ll M,ll N,ll L,ll K,vector<ll> A) {
    ll cnt = 0, pre = 0;
    for (int i = 1; i <= N; i++) {
        if (A[i] - pre >= M && L - A[i] >= M) {
            cnt += 1;
            pre = A[i];
        }
    }
    if (cnt >= K) return trues;
    return false;
}

int main()
{
    // Step #1. 入力
    ll N, L, K;
    cin >> N >> L;
    cin >> K;
    vector<ll> A(N);
    for (int i = 0;i < N;i++) cin >> A[i];

    // Step #2. 答えで二分探索（めぐる式二分探索法）
    // https://qiita.com/drken/items/97e37dd6143e33a64c8c
    ll left = -1;
    ll right = L + 1;
    while (right - left > 1) {
        ll mid = left + (right - left) / 2;
        if (solve(mid,N,L,K,A) == false) {
            right = mid;
        }
        else left = mid;
    }
    cout << left << endl;
    return 0;

}
