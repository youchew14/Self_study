i, j, k = map(int, input().split())

if (i == j and j == k):
    print(10000+i*1000)

elif (i == j or j == k):
    print(1000+j*100)

elif (i == k):
    print(1000+i*100)
else:
    print(max(i, j, k) * 100)