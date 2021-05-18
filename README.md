Python:

```
PS C:\p\cdk-comp\py> cdk init app --language=python
Applying project template app for python
...

Please run 'python -m venv .venv'!
Executing Creating virtualenv...
```

Node:

```
PS C:\p\cdk-comp\ts> cdk init app --language=typescript
Applying project template app for typescript

...

Initializing a new git repository...
Executing npm install...
npm WARN deprecated request-promise-native@1.0.9: request-promise-native has been deprecated because it extends the now deprecated request package, see https://github.com/request/request/issues/3142
npm WARN deprecated request@2.88.2: request has been deprecated, see https://github.com/request/request/issues/3142
npm WARN deprecated resolve-url@0.2.1: https://github.com/lydell/resolve-url#deprecated
npm WARN deprecated urix@0.1.0: Please see https://github.com/lydell/urix#deprecated
npm WARN deprecated har-validator@5.1.5: this library is no longer supported
npm notice created a lockfile as package-lock.json. You should commit this file.
npm WARN optional SKIPPING OPTIONAL DEPENDENCY: fsevents@^2.1.2 (node_modules\jest-haste-map\node_modules\fsevents):
npm WARN notsup SKIPPING OPTIONAL DEPENDENCY: Unsupported platform for fsevents@2.3.2: wanted {"os":"darwin","arch":"any"} (current: {"os":"win32","arch":"x64"})
npm WARN ts@0.1.0 No repository field.
npm WARN ts@0.1.0 No license field.

F#:

```
PS C:\p\cdk-comp\fs> cdk init --language=fsharp
Applying project template app for fsharp
Project `Fs\Fs.fsproj` added to the solution.

```

Preparation, `Python`:

```
PS C:\p\cdk-comp\py> .\.venv\Scripts\activate
(.venv) PS C:\p\cdk-comp\py> pip install -r .\requirements.txt
Obtaining file:///C:/p/cdk-comp/py (from -r .\requirements.txt (line 1))
Collecting aws-cdk.core==1.104.0
  Using cached aws_cdk.core-1.104.0-py3-none-any.whl (938 kB)
Collecting constructs<4.0.0,>=3.3.69
  Using cached constructs-3.3.75-py3-none-any.whl (74 kB)
Collecting aws-cdk.cx-api==1.104.0
  Using cached aws_cdk.cx_api-1.104.0-py3-none-any.whl (130 kB)
Collecting jsii<2.0.0,>=1.29.0
  Using cached jsii-1.29.0-py3-none-any.whl (286 kB)
Collecting publication>=0.0.3
  Using cached publication-0.0.3-py2.py3-none-any.whl (7.7 kB)
Collecting aws-cdk.region-info==1.104.0
  Using cached aws_cdk.region_info-1.104.0-py3-none-any.whl (61 kB)
Collecting aws-cdk.cloud-assembly-schema==1.104.0
  Using cached aws_cdk.cloud_assembly_schema-1.104.0-py3-none-any.whl (129 kB)
Collecting cattrs~=1.5.0; python_version >= "3.7"
  Using cached cattrs-1.5.0-py3-none-any.whl (19 kB)
Collecting typing-extensions~=3.7
  Using cached typing_extensions-3.10.0.0-py3-none-any.whl (26 kB)
Collecting python-dateutil
  Using cached python_dateutil-2.8.1-py2.py3-none-any.whl (227 kB)
Collecting attrs~=20.1
  Using cached attrs-20.3.0-py2.py3-none-any.whl (49 kB)
Collecting six>=1.5
  Using cached six-1.16.0-py2.py3-none-any.whl (11 kB)
Installing collected packages: attrs, cattrs, typing-extensions, six, python-dateutil, jsii, publication, constructs, aws-cdk.cloud-assembly-schema, aws-cdk.cx-api, aws-cdk.region-info, aws-cdk.core, py
  Running setup.py develop for py
Successfully installed attrs-20.3.0 aws-cdk.cloud-assembly-schema-1.104.0 aws-cdk.core-1.104.0 aws-cdk.cx-api-1.104.0 aws-cdk.region-info-1.104.0 cattrs-1.5.0 constructs-3.3.75 jsii-1.29.0 publication-0.0.3 py python-dateutil-2.8.1 six-1.16.0 typing-extensions-3.10.0.0
WARNING: You are using pip version 20.2.3; however, version 21.1.1 is available.
You should consider upgrading via the 'c:\p\cdk-comp\py\.venv\scripts\python.exe -m pip install --upgrade pip' command.
```

Run ls:

```
(.venv) PS C:\p\cdk-comp\py> measure-command { cdk ls }

TotalSeconds      : 2,6120541
```

Typescript:

```
(.venv) PS C:\p\cdk-comp\ts> Measure-Command { cdk ls }

TotalSeconds      : 3,3187953
```

F#:

```

(.venv) PS C:\p\cdk-comp\fs> Measure-Command { cdk ls }

TotalSeconds      : 4,4999606

```


