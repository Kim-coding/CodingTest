#include <iostream>
#include <vector>

using namespace std;

int N, M;
vector<int> sequence;
vector<bool> visited;

void Backtreack(int depth)
{
	if (depth == M)
	{
		for (int num : sequence)
			cout << num << " ";
		cout << "\n";
		return;
	}

	for (int i = 0; i < N; i++)
	{
		if (!visited[i])
		{
			visited[i] = true;
			sequence.push_back(i + 1);
			Backtreack(depth + 1);
			sequence.pop_back();
			visited[i] = false;
		}
	}
}

int main()
{
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	cin >> N >> M;
	visited.resize(N, false);

	Backtreack(0);

	return 0;
}