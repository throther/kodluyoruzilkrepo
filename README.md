Proje 1
[22,27,16,2,18,6] -> Insertion Sort

Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.

Sıralama yapmak için en küçüğü arıyoruz. 
[2,27,16,22,18,6] 
[2,6,16,22,18,27] 
[2,6,16,22,18,27] Burada 16 sayısı en küçük 3.eleman olduğundan dolayı müdahale etmiyoruz.
[2,6,16,18,22,27] 

Big-O gösterimini yazınız.

n ile başlar, n-1,n-2,n-3 ve 1 ile son bulur. 
Bu sayıların toplamı (n*(n+1))/2 olduğundan O(n²) ile ifade edilir.

Time Complexity: Dizi sıralandıktan sonra 18 sayısı aşağıdaki case'lerden hangisinin kapsamına girer? Yazınız
Average case


Proje 2 

[16,21,11,8,12,22] -> Merge Sort

Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.

Diziyi ikiye böl: [16,21,11] [8,12,22]

Alt dizileri tekrar böl: [16] [21,11] [8] [12,22]

Tek elemanlı diziler elde edilene kadar bölmeye devam et: [16] [21] [11] [8] [12] [22]

İkili grupları sıralayarak birleştir: [16] [11,21] [8] [12,22]

Dörder elemanlı grupları sıralayarak birleştir: [11,16,21] [8,12,22]

Son birleştirme ile sıralı diziyi elde et: [8,11,12,16,21,22]


Big-O gösterimini yazınız.

O(n log n)