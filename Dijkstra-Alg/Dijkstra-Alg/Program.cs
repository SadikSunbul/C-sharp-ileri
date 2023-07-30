using System;
using System.Collections.Generic;

class Node
{
    public string Name { get; set; } // Düğümün adını tutmak için bir özellik (property)
    public List<Edge> Edges { get; set; } = new List<Edge>(); // Düğümü diğer düğümlere bağlayan kenarları içeren liste (Edge) özelliği
    public int DistanceFromStart { get; set; } = int.MaxValue / 2; // Düğüme başlangıç düğümünden olan uzaklığını saklamak için bir özellik (önce başlangıçta sonsuz uzaklıkla başlatılır, sonra Dijkstra algoritmasıyla güncellenir)
    public Node PreviousNode { get; set; } // Düğüme en kısa yolda önceki düğümü saklamak için bir özellik

    public Node(string name)
    {
        Name = name;
    }

    public override string ToString() => Name;
}

class Edge
{
    public Node TargetNode { get; set; } // Kenarın hedef düğümünü tutan bir özellik (property)
    public int Weight { get; set; } // Kenarın ağırlığını (uzunluğunu) tutan bir özellik (property)
}

class DijkstraAlgorithm
{
    public static List<Node> FindShortestPath(Node start, Node target)
    {
        List<Node> shortestPath = new List<Node>();
        start.DistanceFromStart = 0; // Başlangıç düğümünden başlangıç düğümüne olan mesafe 0 olarak ayarlanır

        List<Node> unvisitedNodes = new List<Node>();

        foreach (var node in GetAllNodes(start))
        {
            unvisitedNodes.Add(node); // Bütün düğümler unvisitedNodes listesine eklenir
        }

        while (unvisitedNodes.Count > 0)
        {
            unvisitedNodes.Sort((x, y) => x.DistanceFromStart.CompareTo(y.DistanceFromStart)); // Uzaklığa göre unvisitedNodes listesini sıralar
            Node currentNode = unvisitedNodes[0]; // En yakın düğümü seçer
            unvisitedNodes.Remove(currentNode); // Seçilen düğümü unvisitedNodes listesinden çıkarır

            foreach (var edge in currentNode.Edges)
            {
                int tentativeDistance = currentNode.DistanceFromStart + edge.Weight; // Mevcut düğüme olan uzaklıkla kenarın uzunluğunu ekler ve geçici bir mesafe elde eder

                if (tentativeDistance < edge.TargetNode.DistanceFromStart)
                {
                    edge.TargetNode.DistanceFromStart = tentativeDistance; // Eğer geçici mesafe, hedef düğümün mevcut uzaklığından daha küçükse, hedef düğümün uzaklığını günceller
                    edge.TargetNode.PreviousNode = currentNode; // Hedef düğüme en kısa yolda önceki düğümü olarak şu anki düğümü işaretler
                }
            }
        }

        Node backtrackingNode = target;
        while (backtrackingNode != null)
        {
            shortestPath.Insert(0, backtrackingNode); // Hedef düğümden başlayarak en kısa yolu shortestPath listesine ekler
            backtrackingNode = backtrackingNode.PreviousNode; // Önceki düğüme geri döner, böylece tüm yolu bulmuş olur
        }

        return shortestPath; // En kısa yolu döndürür
    }

    private static IEnumerable<Node> GetAllNodes(Node startNode)
    {
        List<Node> nodes = new List<Node>();
        HashSet<Node> visited = new HashSet<Node>();

        Stack<Node> stack = new Stack<Node>();
        stack.Push(startNode);

        while (stack.Count > 0)
        {
            Node node = stack.Pop();
            if (!visited.Contains(node))
            {
                visited.Add(node);
                nodes.Add(node); // Düğümleri ziyaret edilmiş olarak işaretler ve nodes listesine ekler

                foreach (Edge edge in node.Edges)
                {
                    stack.Push(edge.TargetNode); // Düğümün kenarlarındaki hedef düğümleri stack'e ekler (DFS tarayıcısı)
                }
            }
        }

        return nodes; // Tüm düğümleri içeren nodes listesini döndürür
    }
}

class Program
{
    static void Main()
    {
        // Düğümleri oluştur
        Node a = new Node("A");
        Node b = new Node("B");
        Node c = new Node("C");
        Node d = new Node("D");
        Node e = new Node("E");
        Node f = new Node("F");

        // Kenarları oluştur ve düğümlere ekle (Çift yönlü olarak)
        a.Edges.Add(new Edge() { TargetNode = b, Weight = 2 });
        a.Edges.Add(new Edge() { TargetNode = d, Weight = 8 });

        b.Edges.Add(new Edge() { TargetNode = a, Weight = 2 });
        b.Edges.Add(new Edge() { TargetNode = e, Weight = 7 });
        b.Edges.Add(new Edge() { TargetNode = d, Weight = 5 });

        d.Edges.Add(new Edge() { TargetNode = a, Weight = 8 });
        d.Edges.Add(new Edge() { TargetNode = b, Weight = 5 });
        d.Edges.Add(new Edge() { TargetNode = e, Weight = 3 });
        d.Edges.Add(new Edge() { TargetNode = f, Weight = 2 });

        e.Edges.Add(new Edge() { TargetNode = b, Weight = 7 });
        e.Edges.Add(new Edge() { TargetNode = d, Weight = 3 });
        e.Edges.Add(new Edge() { TargetNode = f, Weight = 1 });
        e.Edges.Add(new Edge() { TargetNode = c, Weight = 9 });

        f.Edges.Add(new Edge() { TargetNode = d, Weight = 2 });
        f.Edges.Add(new Edge() { TargetNode = e, Weight = 1 });
        f.Edges.Add(new Edge() { TargetNode = c, Weight = 3 });

        c.Edges.Add(new Edge() { TargetNode = e, Weight = 9 });
        c.Edges.Add(new Edge() { TargetNode = f, Weight = 3 });

        // Dijkstra algoritmasını kullanarak en kısa yolu bul
        List<Node> shortestPath = DijkstraAlgorithm.FindShortestPath(a, c);

        // En kısa yol sonucunu kontrol et ve ekrana yazdır
        if (shortestPath.Count > 0 && shortestPath[shortestPath.Count - 1] == c)
        {
            Console.WriteLine("En Kısa Yol: " + string.Join(" -> ", shortestPath));
        }
        else
        {
            Console.WriteLine("A noktasından C noktasına yol bulunamadı.");
        }
    }
}
