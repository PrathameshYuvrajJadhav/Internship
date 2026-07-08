let tasks = [];

// Load tasks from localStorage
if (localStorage.getItem("tasks") != null) {
    tasks = JSON.parse(localStorage.getItem("tasks"));
}

// Show tasks when page loads
showTasks();

// Add Task Event
document.getElementById("addTask Btn").addEventListener("click", function () {

    let task = document.getElementById("taskInput").value;

    if (task == "") {
        alert("Please enter a task");
        return;
    }

    tasks.push(task);

    localStorage.setItem("tasks", JSON.stringify(tasks));

    document.getElementById("taskInput").value = "";

    showTasks();
});

// Display Tasks
function showTasks() {

    let output = "";

    tasks.forEach(function (task, index) {

        output += `
            <li class="list-group-item">
                ${task}

                <button class="delete-btn"
                    onclick="deleteTask(${index})">
                    Delete
                </button>
            </li>
        `;
    });

    let taskList = document.getElementById("taskList");

    if (tasks.length === 0) {
        taskList.innerHTML = "<li class='list-group-item'>No Tasks Available</li>";
    }
    else {
        taskList.innerHTML = output;
    }
}

// Delete Task
function deleteTask(index) {

    tasks.splice(index, 1);

    localStorage.setItem("tasks", JSON.stringify(tasks));

    showTasks();
}