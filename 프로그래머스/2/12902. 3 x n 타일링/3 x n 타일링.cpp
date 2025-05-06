#include <string>
#include <vector>

using namespace std;

int solution(int n) {
     const int MOD = 1'000'000'007;

    if (n % 2 != 0) return 0;

    int p = n / 2;
    vector<long long> dp(p + 1);
    dp[0] = 1;
    dp[1] = 3;

    for (int i = 2; i <= p; i++) {
        dp[i] = (4 * dp[i - 1] - dp[i - 2] + MOD) % MOD;
    }

    return dp[p];
}