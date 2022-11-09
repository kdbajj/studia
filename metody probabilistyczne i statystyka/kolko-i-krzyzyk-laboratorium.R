Powt<-1000              # Ustalamy liczbę partii
gr1<-0                  # wyzeruj liczbę zwycięstw gracza 1
dl_partii<-rep(0,Powt)  # utwórz tablicę do zapisu liczby
# posunięć w poszczególnych partiach
zaj_pola<-rep(0,Powt)   # utwórz tablicę do zapisu liczby
# zajętych pól w poszczeg. partiach

for(i in 1:Powt){
  #---------------------------------------------------------
  # Kod procedury symulującej jedną partię (O i X)  
  Pole<-matrix(rep(0,9),nrow=3)  # Wyzeruj planszę 3x3 
  gracz<-1;     # gracze będą stawiali na planszy 1 i -1
  zap_pola<-0;  # wyzeruj licznik zapełnionych pól
  N<-0          # wyzeruj licznik posunięć w partii
  
  while(zap_pola<9){  # dopóki są wolne pola wykonuj 
    N<-N+1      # uaktualnij numer posunięcia
    xx<-sample(1:3,1)   # wylosuj ...
    yy<-sample(1:3,1)   # ... współrzędne
    if(Pole[yy,xx]==0){    # jeśli wylosowano puste pole
      Pole[yy,xx]<-gracz;  # postaw znak gracza
      zap_pola<-zap_pola+1 # zwiększ licznik zajętych pól
    }
    # policz, ile jest układów trzech 1 w jednej linii
    # poziomej, pionowej lub ukośnej
    S1<-sum(rowSums(Pole)==3)+sum(colSums(Pole)==3)+
      sum(sum(diag(Pole))==3)+
      sum(sum(diag(apply(Pole,2,rev)))==3)
    # policz, ile jest układów trzech -1 w jednej linii
    # poziomej, pionowej lub ukośnej    
    S2<-sum(rowSums(Pole)==-3)+sum(colSums(Pole)==-3)+
      sum(sum(diag(Pole))==-3)+
      sum(sum(diag(apply(Pole,2,rev)))==-3)
    if(S1+S2>0) break # jeśli pojawił się układ potrójny,
    # to przerwij partię
    gracz<- -gracz    # ruch otrzymuje przeciwnik 
  }
  #---------------------------------------------------------
  if(gracz==1) gr1<-gr1+1 # jeśli wygrał gracz 1, zwiększ
  # jego licznik
  dl_partii[i]<-N        # zapisz liczbę posunięć
  # w i-tej partii
  zaj_pola[i]<-zap_pola   # zapisz liczbę zajętych pól
  # w i-tej partii
}

# 1.Wypisz ułamek zwycięstw 1 gracza (czyli przybliżone
# prawdopodobieństwo zwycięstwa 1 gracza)
gr1/Powt

# 2.Narysuj histogram ("rozkład") liczby zajętych pól
hist(zaj_pola)

# 3.Narysuj histogram liczby posunięć w partiach
hist(dl_partii, breaks=40)

#======================
#Analiza
#======================
#1.Który graacz wygrywa?

gr1/Powt

#Szacowane prawdop. zwycięstwa gracza i wynosi około 0.6
#Wniosek: gracz 1 jest faworytem

#barplot(zaj_pola, names.arg = 1:Powt)

#wniosek: mało prawdopodobne wartości też się zdarzają :)))
mean(zaj_pola)

#2.Średnia liczba zajętych pól wynosi 7

#wykonujemy histogram
#zm$count/Powt
hist(zaj_pola)
grid()
#wniosek: najczęściej zaznaczonych jest 7, 8 lub 9 pól

#3.Długość partii
barplot(dl_partii, names.arg = 1:Powt)
max(dl_partii)

#wniosek: typowe wartości ekstremalne liczby posunięć oscylują 
#w przedziale [50,90]

mean(dl_partii)

#średnia długość partii to ok 15

hist(dl_partii, breaks=35, col="purple",freq = F)

curve(dweibull(x,1.5,10),0,65,add = T)

barplot(rweibull(1000,1.5,10)+3)
plot(density(dl_partii))

#wniosek: rozkład prawdopodobieństwa zmiennej losowej "liczba posunięć" 
#przypomina rozkład weibull'a

