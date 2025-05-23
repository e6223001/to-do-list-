body {
  font-family: 'Inter', sans-serif;
  background: linear-gradient(to right, #f5f7fa, #c3cfe2);
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  margin: 0;
}

.container {
  background: white;
  padding: 25px 30px;
  border-radius: 12px;
  box-shadow: 0 12px 24px rgba(0, 0, 0, 0.1);
  width: 360px;
}

h1 {
  text-align: center;
  margin-bottom: 20px;
  color: #333;
  font-weight: 600;
}

.input-container {
  display: flex;
  gap: 10px;
  margin-bottom: 20px;
}

#taskInput {
  flex: 1;
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 8px;
  font-size: 14px;
}

#addTaskBtn {
  padding: 10px 14px;
  border: none;
  background-color: #6c63ff;
  color: white;
  font-weight: 600;
  border-radius: 8px;
  cursor: pointer;
  transition: background 0.2s;
}

#addTaskBtn:hover {
  background-color: #574fd6;
}

#taskList {
  list-style: none;
  padding: 0;
}

.task-item {
  display: flex;
  justify-content: space-between;
  align-items: center;
  background: #f8f9fa;
  border: 1px solid #e0e0e0;
  padding: 10px 12px;
  border-radius: 8px;
  margin-bottom: 10px;
}

.task-item.completed .task-text {
  text-decoration: line-through;
  color: #999;
}

.task-text {
  flex: 1;
  font-size: 15px;
  color: #333;
}

.task-buttons {
  display: flex;
  gap: 6px;
}

.task-buttons button {
  border: none;
  padding: 6px 10px;
  border-radius: 6px;
  font-weight: bold;
  cursor: pointer;
  transition: background 0.2s;
}

.task-buttons button:first-child {
  background-color: #00b894;
  color: white;
}

.task-buttons button:first-child:hover {
  background-color: #019875;
}

.task-buttons button:last-child {
  background-color: #d63031;
  color: white;
}

.task-buttons button:last-child:hover {
  background-color: #c0392b;
}
