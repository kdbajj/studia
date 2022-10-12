u1<-c("B","B","c") #ctrl + Enter
u2<-c("B","C","c")

N<-1000 #liczba powt.
licznik<-0

for(i in 1:N){
  K1<-sample(u1,1)
  K2<-sample(c(u2,K1),1)
  if(K2=="B") licznik<-licznik+1
}
licznik/N
