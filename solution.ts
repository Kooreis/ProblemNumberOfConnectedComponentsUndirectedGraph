Here is a TypeScript solution for finding the number of connected components in an undirected graph:

```typescript
class Graph {
    private vertices: number;
    private adj: number[][];

    constructor(vertices: number) {
        this.vertices = vertices;
        this.adj = Array.from({ length: vertices }, () => []);
    }

    addEdge(v: number, w: number): void {
        this.adj[v].push(w);
        this.adj[w].push(v);
    }

    DFS(v: number, visited: boolean[]): void {
        visited[v] = true;
        for (let i = 0; i < this.adj[v].length; ++i) {
            let n = this.adj[v][i];
            if (!visited[n]) {
                this.DFS(n, visited);
            }
        }
    }

    connectedComponents(): number {
        let visited: boolean[] = Array.from({ length: this.vertices }, () => false);
        let count = 0;
        for (let v = 0; v < this.vertices; ++v) {
            if (!visited[v]) {
                this.DFS(v, visited);
                count++;
            }
        }
        return count;
    }
}

let g = new Graph(5);
g.addEdge(1, 0);
g.addEdge(2, 3);
g.addEdge(3, 4);
console.log(g.connectedComponents());
```

This program creates a Graph class with methods for adding edges and performing a depth-first search (DFS). The `connectedComponents` method uses DFS to find all connected components in the graph. It initializes an array to keep track of visited vertices, then iterates over all vertices. If a vertex has not been visited, it performs a DFS from that vertex and increments a count of connected components. The program then creates a graph, adds some edges, and prints the number of connected components.