let info = [];

// Load data from localStorage
if (localStorage.getItem("info") != null) {
    info = JSON.parse(localStorage.getItem("info"));
}

// Show data on page load
showInfo();

// Form Submit Event
document.querySelector(".info-form").addEventListener("submit", function (e) {

    e.preventDefault();

    let name = document.getElementById("uname").value;
    let course = document.getElementById("course").value;

    info.push({
        name: name,
        course: course
    });

    localStorage.setItem("info", JSON.stringify(info));

    document.getElementById("uname").value = "";
    document.getElementById("course").value = "";

    showInfo();
});

// Display Info
function showInfo() {

    let output = "";

    info.forEach(function (student, index) {

        output += `
        <div class="card">
            <h3>${student.name}</h3>
            <p>Course: ${student.course}</p>

            <button class="btn-delete"
                    onclick="deleteInfo(${index})">
                Delete
            </button>
        </div>
        `;
    });

    let phonebook = document.getElementById("phonebook");

    if (info.length === 0) {

        phonebook.innerHTML =
        'Nothing to show! Use "Add Info" section above to add student information.';

    } else {

        phonebook.innerHTML = output;
    }
}

// Delete Info
function deleteInfo(index) {

    info.splice(index, 1);

    localStorage.setItem("info", JSON.stringify(info));

    showInfo();
}