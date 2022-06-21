function y=rzad_mac_p_2(m)
  [q p]=size(m);
  okay = true;
  c=0;
  
  if(p!=2 || q!=2)
    disp("Macierz nie jest px2")
  else
   for i=1:q
     for j=1:p
       if(m(i,j)==0)
          c++;
       endif
     endfor
   endfor
   
   if(c==4)
    y=0;
   endif
   
   if(m(2,1)==0 && m(2,2)==0 && c!=4 || m(1,1)==0 && m(1,2)==0 && c!=4)
    y=1;
    c=4;
   endif
   
   s=m(1,2);
   d=m(1,1);
   x=s/d;

   if(c!=4)
     for i=2:p
        s=m(i,2);
        d=m(i,1);
        z=s/d;
        if(z!=x)
          okay=false;
        endif 
    endfor
   endif
   
   if(okay==true && c!=4)
    y=1;
   endif
   if(okay==false && c!=4)
    y=2;
   endif
   
  endif
endfunction