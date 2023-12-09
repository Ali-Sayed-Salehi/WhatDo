import axios from 'axios';
import { useEffect, useState } from 'react';

interface ToDoItem {
    id: number;
    name: string;
    description: string;
    dueDate: Date;
    isCompleted: boolean;
}

function App() {
    const [toDoItems, setToDoItems] = useState<ToDoItem[]>();

    useEffect(() => {
        getToDoItems();
    }, []);

    if (toDoItems === undefined) {
        return (
            <div>
                no todo items
            </div>
        )
    }


    return (
        <div>
            <ul>
                {toDoItems.map(item => (
                    <li key={item.id}>
                        {item.description}
                    </li>
                ))}
            </ul>
        </div>
    );

    async function getToDoItems() {

        try {
            const response = await axios.get('https://localhost:7071/api/ToDoItems');
            setToDoItems(response.data);
        } catch (error) {
            console.error(error);
        }
    }
}

export default App;