DFS(v, visited) {
        visited[v] = true;
        let get_neighbours = this.AdjList.get(v);
        for (let i in get_neighbours) {
            let get_elem = get_neighbours[i];
            if (!visited[get_elem])
                this.DFS(get_elem, visited);
        }
    }