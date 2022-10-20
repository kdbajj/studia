Powt<-10000

Pole<-matrix(rep(0,9),nrow=3)
Pole[1,]<-1
zajPola<-0
gracz<-1;N<-0

while(zajPola<9){
  xx<-sample(1:3,1); yy<-sample(1:3,1)
  if(Pole[yy,xx]==0){
    Pole[yy,xx]<-gracz
    zajPola<zajPola+1
  }
  s1<-sum(rowSums(Pole)==3)+
    sum(colSums(Pole)==3)+
    sum(sum(diag(Pole))==3)+
    sum(sum(diag(apply(Pole,2,rev)))==3)
  
  s2<-sum(rowSums(Pole)==-3)+
    sum(colSums(Pole)==-3)+
    sum(sum(diag(Pole))==-3)+
    sum(sum(diag(apply(Pole,2,rev)))==-3) 
  if(S1+S2>0)break
  gracz<- -gracz
}

 
Pole
