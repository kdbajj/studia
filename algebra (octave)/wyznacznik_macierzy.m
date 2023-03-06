function y=wyznacznik_macierzy(m1)
[p q] = size(m1);
    if(p!=q)
      disp("Macierz nie jest kwadratowa")
    else
      wyznacznik = 0;
    if(p==2)
      wyznacznik = (m1(1,1) * m1(2,2)) - (m1(2,1) * m1(1,2));
    else
      for x = 1: p;
        li = 1;
          for i = 2: p;
            lj = 1;
          for j = 1: p;
        if(j != x)
          m2(li,lj) = m1(i,j);
          lj++;
        endif
    endfor
      li++;
    endfor
      wyznacznik += power(-1,x-1) * m1(1,x) * wyznacznik_macierzy(m2);
    endfor
  endif
  y = wyznacznik;
endif
endfunction