function wyznacznik=wyznacznik_macierzy(m1);
[x,y]=size(m1);
obl=0;
if(x==y)
  if(x==1)
    wyznacznik=m1(1,1);
 
    else
      if(x==3)
        wyznacznik=((m1(1,1)*m1(2,2)*m1(3,3))+(m1(1,2)*m1(2,3)*m1(3,1))+(m1(1,3)*m1(2,1)*m1(3,2)))-((m1(3,1)*m1(2,2)*m1(1,3))+(m1(3,2)*m1(2,3)*m1(1,1))+(m1(3,3)*m1(2,1)*m1(1,2)));
         else
    if(x==2)
      wyznacznik=(m1(1,1)*m1(2,2))-(m1(2,1)*m1(1,2));
      else
        wyznacznik=0;
        if(x>3)
          wyznacznik=0;
          for i=1:x
            m=0;
            n=0;
            for j=2:x
              n=n+1;
              for k=1:i-1
                m=m+1;
                m2(n,m)=m1(j,k);
              endfor
              for k=i+1:x
                m=m+1;
                m2(n,m)=m1(j,k);
              endfor
              m=0;
            endfor
            wyznacznik=wyznacznik+(m1(1,i)*((-1)^(1+i))*wyznacznik_macierzy(m2));
          endfor
        endif
      endif
    endif
  endif
else
  printf("Macierz nie jest kwadratowa\n");
endif
endfunction