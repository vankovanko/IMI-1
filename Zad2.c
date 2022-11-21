#include <stdio.h>
int main(){
int dalj;
int vis;
printf("Vavedete dalj:");
scanf("%d",&dalj);
printf("Vavedete vis:");
scanf("%d",&vis);
printf("Liceto e:%d\n", dalj*vis);
printf("Perimetara e:%d",2*dalj+2*vis);
return 0;
}
