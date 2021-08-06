

#include <iostream>
#include<queue>


using namespace std;

#define ll long long
#define rep(i,n) for(int i=0;i<n;i++)

int main()
{
    priority_queue<ll, vector<ll>, greater<ll> >pq;

    int Q_depth, label;
    cin >> Q_depth;

    ll x;

    ll add_number = 0;
    ll min_value;

    for (int i = 0;i < Q_depth;i++) {
        cin >> label;

        if (label == 1) {
            cin >> x;

            pq.push(x - add_number);

        }
        else if (label == 2) {
            cin >> x;
            add_number += x;
        }
        else if (label == 3) {

            min_value = pq.top();
            cout << min_value + add_number << endl;
            pq.pop();
        }
    }

    
}
