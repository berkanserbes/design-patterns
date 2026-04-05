# Getting Started — Node.js / TypeScript

This guide explains how to set up and run the Node.js / TypeScript examples in this repository.

---

## Prerequisites

| Requirement | Minimum Version | Download |
|-------------|----------------|---------|
| Node.js | 18 (LTS) | [nodejs.org](https://nodejs.org/) |
| npm | 9+ | Bundled with Node.js |
| IDE (optional) | — | [VS Code](https://code.visualstudio.com/) |

Verify your installation:

```bash
node --version
# Expected: v18.x.x or higher

npm --version
# Expected: 9.x.x or higher
```

---

## Repository Structure

All Node.js projects live under `nodejs/DesignPatterns/`. Every leaf folder is a completely **standalone npm project** with its own `package.json` and TypeScript source files.

```
nodejs/
└── DesignPatterns/
    ├── CreationalDesignPatterns/
    │   ├── AbstractFactoryDesignPattern/
    │   │   ├── AbstractFactoryDesignPattern.Example1/
    │   │   │   ├── package.json
    │   │   │   ├── tsconfig.json
    │   │   │   └── src/
    │   │   │       └── index.ts      ← entry point
    │   │   └── ...
    │   └── ...
    ├── StructuralDesignPatterns/
    └── BehavioralDesignPatterns/
```

Each example runs with `ts-node` directly from TypeScript source — no separate compile step required.

---

## Running a Single Example

### Step 1 — Install dependencies

```bash
# Navigate into any example folder
cd nodejs/DesignPatterns/CreationalDesignPatterns/AbstractFactoryDesignPattern/AbstractFactoryDesignPattern.Example1

# Install packages
npm install
```

### Step 2 — Run the example

```bash
npm start
```

That's it. The `start` script in every `package.json` is:

```json
"scripts": {
  "start": "ts-node src/index.ts"
}
```

---

## Running All Examples at Once (PowerShell)

You can install and run every example in sequence with this PowerShell script. Run it from the repository root:

```powershell
Get-ChildItem -Path nodejs/DesignPatterns -Filter package.json -Recurse | ForEach-Object {
    Write-Host "`n=== $($_.Directory.Name) ===" -ForegroundColor Cyan
    Push-Location $_.DirectoryName
    npm install --silent
    npm start
    Pop-Location
}
```

---

## Cleaning node_modules

Since each example is a separate npm project, `node_modules` folders accumulate quickly. To remove them all at once:

```powershell
# PowerShell — removes all node_modules under nodejs/
Get-ChildItem -Path nodejs -Filter node_modules -Recurse -Directory |
    Remove-Item -Recurse -Force
Write-Host "All node_modules removed."
```

```bash
# Bash
find nodejs -type d -name node_modules -exec rm -rf {} +
echo "All node_modules removed."
```

To reinstall all at once afterwards, re-run the **Running All Examples** script above.

---

## TypeScript Configuration

Each project ships with a minimal `tsconfig.json`:

```json
{
  "compilerOptions": {
    "target": "ES2020",
    "module": "commonjs",
    "strict": true,
    "esModuleInterop": true,
    "experimentalDecorators": true,
    "emitDecoratorMetadata": true,
    "outDir": "./dist"
  },
  "include": ["src/**/*"]
}
```

`experimentalDecorators` and `emitDecoratorMetadata` are enabled for projects that use decorator-based libraries (e.g. `mediatr-ts` in the Mediator examples).

---

## Building to JavaScript (optional)

If you want to compile to plain JavaScript instead of using `ts-node`:

```bash
npm run build        # compiles src/ → dist/
node dist/index.js   # run compiled output
```

---

## Troubleshooting

| Problem | Solution |
|---------|----------|
| `ts-node: command not found` | Run `npm install` inside the project folder first |
| `Cannot find module '...'` | Run `npm install` — `node_modules` may have been deleted |
| `experimentalDecorators` warning | This is expected; the option is already set in `tsconfig.json` |
| Port already in use (Proxy/Factory examples with Express) | Kill the process using the port or change the port in the source |

---

## Back to Main README

[← Back to README](../README.md)
