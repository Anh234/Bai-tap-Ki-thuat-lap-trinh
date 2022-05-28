// pham ngoc anh- 20206117

#include<stdio.h>
#include<conio.h>
 
int string_ln(char*);
 
int main() {
   char str[50];
   int length;
    
   printf("\nNhap chuoi bat ky: ");
   gets(str);
    
   length = string_len(str);
   printf("\nDo dai chuoi %s la: %d", str, length);
  return(0);
}
 
/*
 * ham tinh do dai cua mang boi su sung con tro
 *
 * chuoi trong c duoc luu tru lien tuc trong bo nho 
 * va ket thuc boi null ('\0')
 * do vay ta se tro con tro ptr vao o nho tiep theo cho den gia tri null
 */
int string_len(char *p) {
   int count = 0;
   while (*p != '\0') {
      count++;
      p++;
   }
   return count;
}
