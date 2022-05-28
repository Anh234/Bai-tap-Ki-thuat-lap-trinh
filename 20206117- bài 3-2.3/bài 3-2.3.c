// pham ngoc anh - 20206117

#include<stdio.h>
#include<conio.h>
 
int main() {
   int arr[5];
   int i;
   int sum = 0;
   int *ptr;
  
   printf("\nNhap 5 phan tu: \n");
  
   for (i = 0; i < 5; i++) {
       printf("Nhap a[%d] = ", i + 1);
       scanf("%d", &arr[i]);
   }
   // gan dia chi o nho dau tien cua mang arr cho ptr = &arr[0]
   ptr = arr;
  
   // mang trong c duoc luu tru lien tuc trong bo nho
   // do vay ta se tro con tro ptr vao o nho tiep theo va cong vao bien sum
   for (i = 0; i < 5; i++) {
      sum = sum + *ptr;
      ptr++;
   }
  
   printf("Tong cac phan tu cua mang la: %d", sum);
   return(0);
}
