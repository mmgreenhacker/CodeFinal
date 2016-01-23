%Thank you for the reply. I apologize for the incomplete information i gave, but the coding and decoding part are quite big and i didn't want to be impractical. 

%This is the coding, which seems to be working well. 

function [Store_Byte,Counts,Table]=Arith_Code(Data) 


Table=0; New_Data=0; 

' Compute Table of Symbols ...' 
Table(1)=Data(1); 
S_AC=size(Data); 
    for jAC=1:S_AC(2) 
        S_2AC=size(Table);Flag=0; 
        for kAC=1:S_2AC(2) 
            if (Table(kAC)==Data(jAC)) 
                Flag=1; 
            end; 
        end; 
        if (Flag==0) Table(S_2AC(2)+1)=Data(jAC); end; 
    end; 
  
 ' Compute the probability of the symbols...'   
  
 %%----------------------------------------- 
  S_2AC=size(Table); 
  Counts(1:S_2AC(2))=0; 
   for kAC=1:S_AC(2) 
        iAC=1; 
        while (Table(iAC)~=Data(kAC)) 
            iAC=iAC+1; 
        end; 
          New_Data(kAC)=iAC; 
          Counts(iAC)=Counts(iAC)+1; 
    end; 
 %%%------------------------------------- 
 code=0; 
    ' Apply Arithmetic coding .... Now' 
    code = arithenco(New_Data,Counts); 
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% 
      
    %%% Converting bits to ASCII and save it into a file.... 
     'converts bits to bytes... Now' 
    D_Bits=char(code+48); % convert bits to characters '1' and '0' 
    
    N_Bits=8; %%% Choose number of bits for convertion 
    i_B=1; Size_AC=size(code); 
    D_Bits(Size_AC(2)+1:Size_AC(2)+N_Bits)='0'; 
    i_B=1;k_Loc=1; 
    while (i_B<=Size_AC(2)) 
     e8bits(1:N_Bits)=D_Bits(i_B:i_B+N_Bits-1); 
     Store_Byte(k_Loc)=bin2dec(e8bits); 
     k_Loc=k_Loc+1; 
     i_B=i_B+N_Bits; 
    end; 
        
    
        
        
end       

%Now the decoding part doesn't seem to be complete because instead of returning my original image it returns an array with the right size but it is binary. 

function [Data]=Arith_Decode(Store_Byte,Counts,Table) 

        
       Counts=double(Counts);   
      
      Store_Byte=double(Store_Byte); 
      ' Compute data size' 
      length_Data=0; 
      Size_Counts=size(Counts); 
      for iAD=1:Size_Counts(2) 
      length_Data=length_Data+Counts(iAD); 
      end; 
      'Read Data from the array...' 
      Size_Data=size(Store_Byte); 
      
      Loc=1; code=0; 
      for iAD=1:Size_Data(2) 
          e8bits=dec2bin(Store_Byte(iAD),8); 
          code(Loc:Loc+7)=e8bits(1:8); 
          Loc=Loc+8; 
      end; 
      code=code-48; 
      'Apply Arithmetic Decode..' 
      New_Data = arithdeco(code,Counts,length_Data); 
      
      Data=0; 
      'Return original data'   
      for iAD=1:length_Data 
       Data(iAD)=Table(New_Data(iAD)); 
      end; 

I% apologize for the long code but it is the last part of my project and i am not sure what to do