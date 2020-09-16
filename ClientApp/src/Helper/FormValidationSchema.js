import * as Yup from 'yup';

export const validateCarSchema = Yup.object().shape({
    make: Yup.string()
        .max(50, "*'Make' can't be longer than 50 characters")
        .required("*'Make' is required"),
    model: Yup.string()
        .max(50, "*'Model' must be less than 50 characters")
        .required("*'Model' is required"),
    engine: Yup.string()
        .max(50, "*'Engine' must be less than 50 characters")
        .required("*'Engine' is required"),
    doors: Yup.number()
        .lessThan(10, "*'Doors' cannot exceed 10")
        .moreThan(0, "*'Doors' cannot be less than 1")
        .required("*'Doors' is required"),
    wheels: Yup.number()
        .lessThan(10, "*'Wheels' cannot exceed 10")
        .moreThan(3, "*'Wheels' cannot be less than 4")
        .required("*'Wheels' is required"),
    bodyType: Yup.string()
        .max(50, "*'Body Type' must be less than 50 characters")
        .required("*'Body Type' is required"),
});

