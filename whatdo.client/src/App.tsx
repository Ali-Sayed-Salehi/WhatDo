import axios from 'axios';
import { useEffect, useState } from 'react';
import { List, ListItem, ListItemText, Typography, Paper } from '@mui/material';

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
        <>
            <Paper elevation={3} style={{ padding: '16px', maxWidth: '600px', margin: 'auto', textAlign: 'center' }}>
                <Typography variant="h4" gutterBottom>
                    Todo List
                </Typography>
                <List>
                    {toDoItems.map((ToDoItem) => (
                        <ListItem key={ToDoItem.id}>
                            <ListItemText
                                primary={ToDoItem.name}
                                secondary={ToDoItem.description}
                            />
                        </ListItem>
                    ))}
                </List>
            </Paper>
            
        </>
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