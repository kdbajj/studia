# cześć III


myFunction <- function(number_of_round,number_of_sum) {
  N <- number_of_round
  kostka_zepsuta <- c(0,2,2,4,4,6)
  nr_partii <- 0
  wyniki <- rep(0, N)
  
  
  for (i in 0:N) {
    for (j in 1:number_of_sum) {
      wyniki[i] <- wyniki[i] + sample(kostka_zepsuta, 1)
    }
  }
  
  
  hist(wyniki, freq = F)
  x <- seq(0, 30, length.out = 100)
  y <- dnorm(x, 17.5, 3)
  par(new=T)
  plot(x, y, type = "l", lwd = 2, col = "red")
}

# Część III
# 1
myFunction(10000, 1)

# 2
myFunction(10000, 2)

# 3
myFunction(10000, 3)

# 4
myFunction(10000, 4)

# 5
myFunction(10000, 5)

# wnioski z części III:
# Im więcej razy rzucamy kostką tym bardziej rozkład zbliża się do rozkładu normalnego.

# część II
myFunction(100000, 1)
myFunction(100000, 2)
myFunction(100000, 3)
myFunction(100000, 4)
myFunction(100000, 5)

# wnioski z części II dla części III:
# Im więcej razy rzucamy kostką tym bardziej rozkład zbliża się do rozkładu normalnego
