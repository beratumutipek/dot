import random as r

hak=3

commp_num = r.randint(1,7)
while(hak>0):
    users_num= int(input("guess a number: "))
    if users_num == commp_num:
        print("you win")
        break
        
    else: 
        hak-=1
        print("try again")
        
if hak==0:
    print("you havent another hak")
    print(commp_num)
