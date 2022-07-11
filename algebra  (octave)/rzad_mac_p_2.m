function y=rzad_mac_p_2(m)
[p b]=size(m);
tylko_zera=true;
for i=1:p
  for j=1:2;
    if m(i,j)!=0
      
      tylko_zera=false;
    endif
  endfor
endfor

if(tylko_zera==true)
y=0;
else 

krzyzek = 1;

for i=1:p
  for j=1+1:p
    if (m(i,1)*m(j,2) != m(j,1)*m(i,2))
      krzyzek = 0;
    endif
  endfor
endfor


if krzyzek == 1
  y=1;
else
  y=2;
endif


endif
 
 
endfunction