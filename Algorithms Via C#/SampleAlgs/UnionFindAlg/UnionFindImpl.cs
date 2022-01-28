namespace UnionFindAlg
{
   public sealed class UnionFindImpl : IUnionFind
   {
      private int[] _ids;  // ������ � �������������� ���������� (���������� ������)

      public UnionFindImpl(int n)
      {  // ������������� �������� ��������������� �����������
         Count = n;
         _ids=new int[n];
         for (int i = 0; i < n; i++)
         {
            _ids[i] = i;
         }
      }

      public void Union(int p, int q)
      {         
      }

      public int Find(int p)
      {
         return 0;
      }

      public bool Connected(int p, int q) => Find(p) == Find(q);

      public int Count { get; }
   }
}