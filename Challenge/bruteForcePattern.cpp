#include <iostream>
#include <list>
#include <cstring>
#include <crypt.h>

using namespace std;

#define MAX 8
#define DATA_SET_LEN 46

string target_salt = "$6$Bkpx5olV$";
string target_pw_hash = "$6$Bkpx5olV$4Rsa0CGyErXokHgzziLCnWfPDaxX31b.QZgna4zJq0dkHYjPeG50HpZowenPCB2K5Hw.hicU8KxVx29I.Tnnx/";

char *salt, *target;

char ch[MAX];

// char charset[DATA_SET_LEN][DATA_SET_LEN] = {"a", "j", "%", "&", "b", "z"};
char charset[DATA_SET_LEN][DATA_SET_LEN] = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "a", "j", "c", "d", "e", "f", "g", "h", "i", "b", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
int check_password(char *pw)
{
	char *res = crypt(pw, salt);

	for (int i = 0; i < strlen(target); i++)
		if (res[i] != target[i])
			return 0;
	cout << "match !!!" << "\n";
	return 1;
}

char *backtrack(int k)
{
	int i;
	char prefix[255] = ">>>:::isinfo20:::<<<";
	char format[] = "*j*%&***";

	for (i = 0; i < DATA_SET_LEN; i++)
	{
		ch[k] = i;
		if (1)
		{
			if (k == MAX - 1)
			{
				char sir[256] = "";
				int likeFormat = 1;
				for (int i = 0; i < MAX; i++)
				{
					if(format[i] == '*') {
						strcat(sir, charset[ch[i]]);
					} else if(format[i] == *charset[ch[i]]) {
						strcat(sir, charset[ch[i]]);
					} else {
						likeFormat = 0;
						break;
					}
				}

				if (likeFormat)
				{
					cout << sir << "\n";
					if(check_password(strcat(prefix, sir))) {
						throw sir;
						break;
					}
				}
			}
			else {
				backtrack(k + 1);
			}
		}
	}
}

int main()
{
	salt = new char[target_salt.length() + 1];
	target = new char[target_pw_hash.length() + 1];

	copy(target_salt.begin(), target_salt.end(), salt);
	copy(target_pw_hash.begin(), target_pw_hash.end(), target);

	try
	{
		backtrack(0);
	}
	catch (char *sir)
	{
		cout << "Password successfuly recovered";
		return 0;
	}

	cout << "Password not found.";
	return 0;
}