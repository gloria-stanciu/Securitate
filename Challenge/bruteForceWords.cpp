#include <iostream>
#include <list>
#include <cstring>
#include <crypt.h>

using namespace std;

#define MAX 5
#define DATA_SET_LEN 46

string target_salt = "$6$uW9m5FvJ$";
string target_pw_hash = "$6$uW9m5FvJ$/c73p9r/awX0uBJptxCH38KlteRc7q2oAA48OhzmkEU2jT8CM.4.k51PWJgbtjeZvkhBcBhkuAR4t.82FO6mw.";

char *salt, *target;
// [0, 0, 0, 0, 0, 0]
char ch[MAX];
char charset[DATA_SET_LEN][10] = { "r", "s", "t", "u", "v", "z", "y", "x", "w", "l", "m", "n", "o", "p", "q", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k","0","1", "2", "3","4", "5", "6","7", "8", "9", "!", "@","#", "$", "%", "^", "&", "*", "(", ")" };

int check_password(char* pw)
{
    char* res = crypt(pw, salt);
    
    for (int i = 0; i < strlen(target); i++)
        if (res[i]!=target[i]) return 0;
		cout << "match !!!" << "\n";
	
    return 1;
}

char* backtrack(int k)
{
	int i;
	char* ceva;
	for (i = 0; i < DATA_SET_LEN; i++)
	{
		ch[k] = i;
		if (1)
		{
			if (k == MAX-1) {
				char sir[256] = ">>>:::isinfo20:::<<<";

				for (int i = 0; i < MAX; i++)
					strcat(sir, charset[ch[i]]);

				cout << sir << "\n";
				if(check_password(sir))
				{
					throw sir;
					break;
				}
			}
			else backtrack(k + 1);
		}
	}
}

int main()
{
	salt = new char[target_salt.length()+1];
	target = new char[target_pw_hash.length()+1];

	copy(target_salt.begin(), target_salt.end(), salt);
	copy(target_pw_hash.begin(), target_pw_hash.end(), target);

	try {
		backtrack(0);
	} catch (char* sir) {
		cout << "Password successfuly recovered";
		return 0;
	}

	cout << "Password not found.";
	return 0;
}