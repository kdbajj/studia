function wynik=iloczyn_m_przez_skalar(l,m)
  [a,b]=size(m);
  for i=1:a
    for j=1:b
      wynik(i,j)=l*m(i,j);
    endfor
  endfor
endfunction