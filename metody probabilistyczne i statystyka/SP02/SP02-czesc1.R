# część I
myFunction <- function(number_of_round,number_of_sum) {
  N <- number_of_round
  kostka <- c(1,2,3,4,5,6)
  nr_partii <- 0
  wyniki <- rep(0, N)
  
  
  for (i in 0:N) {

      for (j in 1:number_of_sum) {
      wyniki[i] <- wyniki[i] + sample(kostka, 1)
    }
  }
  
  hist(wyniki, freq = F)
  x <- seq(0, 30, length.out = 100)
  y <- dnorm(x, 17.5, 3)
  par(new=T)
  plot(x, y, type = "l", lwd = 2, col = "red")
}

# Część I
myFunction(10000, 1)
myFunction(10000, 2)
myFunction(10000, 3)
myFunction(10000, 4)
myFunction(10000, 5)

# wnioski z części I:
# Im więcej razy rzucamy kostką tym bardziej rozkład zbliża się do rozkładu normalnego.

# część II
myFunction(100000, 1)
myFunction(100000, 2)
myFunction(100000, 3)
myFunction(100000, 4)
myFunction(100000, 5)

# wnioski z części II:
# Im więcej razy rzucamy kostką tym bardziej rozkład zbliża się do rozkładu normalnego.
