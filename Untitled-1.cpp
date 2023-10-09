#include <iostream>
using namespace std;
int main() {
    int num1, num2, num3;
    int sum = 0;

    std::cout << "لطفاً سه عدد را وارد کنید: ";
    std::cin >> num1 >> num2 >> num3;

    // تعیین حدود عددها
    int start = (num1 < num2) ? num1 : num2;
    int end = (num1 > num2) ? num1 : num2;

    // محاسبه‌ی مجموع اعداد بین دو عدد که برابر با عدد سوم است
    for (int i = start + 1; i < end; i++) {
        if (i == num3) {
            continue;
        }
        sum += i;
    }

    std::cout << "مجموع اعداد بین " << start << " و " << end << " که برابر با " << num3 << " است، برابر است با: " << sum << std::endl;

    return 0;
}
```
    
