Here is a JavaScript solution using Depth-First Search (DFS) to find the number of connected components in an undirected graph:

```javascript
class Graph {
    constructor(noOfVertices) {
        this.noOfVertices = noOfVertices;
        this.AdjList = new Map();
    }

    addVertex(v) {
        this.AdjList.set(v, []);
    }

    addEdge(v, w) {
        this.AdjList.get(v).push(w);
        this.AdjList.get(w).push(v);
    }

    DFS(v, visited) {
        visited[v] = true;
        let get_neighbours = this.AdjList.get(v);
        for (let i in get_neighbours) {
            let get_elem = get_neighbours[i];
            if (!visited[get_elem])
                this.DFS(get_elem, visited);
        }
    }

    connectedComponents() {
        let visited = {};
        let count = 0;
        for (let i of this.AdjList.keys()) {
            if (!visited[i]) {
                this.DFS(i, visited);
                count++;
            }
        }
        return count;
    }
}

let g = new Graph(5);
let vertices = ['A', 'B', 'C', 'D', 'E'];

for (let i = 0; i < vertices.length; i++) {
    g.addVertex(vertices[i]);
}

g.addEdge('A', 'B');
g.addEdge('A', 'D');
g.addEdge('B', 'E');
g.addEdge('D', 'E');
g.addEdge('E', 'C');

console.log("Number of connected components: " + g.connectedComponents());
```

This code creates a Graph class with methods to add vertices and edges, perform a depth-first search, and find the number of connected components. It then creates a graph, adds vertices and edges, and logs the number of connected components.