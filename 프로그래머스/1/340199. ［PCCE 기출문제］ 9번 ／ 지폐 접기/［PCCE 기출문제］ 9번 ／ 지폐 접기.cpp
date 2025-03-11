#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int solution(vector<int> wallet, vector<int> bill) 
{
    int answer = 0;

    int min_wallet = min(wallet[0], wallet[1]);
    int max_wallet = max(wallet[0], wallet[1]);

    int min_bill = min(bill[0], bill[1]);
    int max_bill = max(bill[0], bill[1]);

    while (min_bill > min_wallet || max_bill > max_wallet)
    {
        max_bill /= 2;
        if (max_bill < min_bill) {
            swap(min_bill, max_bill);
        }
        answer++;
    }

    return answer;
}