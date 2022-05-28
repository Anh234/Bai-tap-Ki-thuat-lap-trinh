// pham ngoc anh- 20206117

#include<stdio.h>
 
int main() {
   int a = 10;
   int b = 20;
     
   int *ptr1, *ptr2;
   // tro ptr1 den dia chi o nha cua a
   ptr1 = &a;
   // tro ptr2 den dia chi o nha cua b
   ptr2 = &b;
    
   // cong hai con tro
   int num;
   num = *ptr1 + *ptr2;
 
   printf("Tong hai so = %d", num);
   return (0);
}
