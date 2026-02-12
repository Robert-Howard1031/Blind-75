public Node CloneGraph(Node node)
    {
        if (node == null)
            return null;

        // maps original node -> cloned node
        var map = new Dictionary<Node, Node>();

        // create the first clone
        map[node] = new Node(node.val);

        // BFS queue starting from the given node
        var queue = new Queue<Node>();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            foreach (var neighbor in current.neighbors)
            {
                // if neighbor hasn't been cloned yet, clone it and enqueue for processing
                if (!map.ContainsKey(neighbor))
                {
                    map[neighbor] = new Node(neighbor.val);
                    queue.Enqueue(neighbor);
                }

                // add the cloned neighbor to the current cloned node's neighbor list
                map[current].neighbors.Add(map[neighbor]);
            }
        }

        return map[node];
    }
