using System.Collections.Generic;
using System;

namespace BlasII.StylePoints.Utils;

/// <summary>
/// Exception thrown when trying to initialize a manager multiple times.
/// </summary>
public class ManagerAlreadyInitializedException<ID, Value> : Exception
{
	/// <summary>
	/// Calls the parent contructor.
	/// </summary>
	public ManagerAlreadyInitializedException(Manager<ID, Value> manager)
		: base($"Manager '{manager.GetType().Name}' was already initialized.")
	{
	}
}

/// <summary>
/// Exception thrown when trying to insert a pair of key value when the key
/// already exists.
/// </summary>
public class ManagedValueIDAlreadyExists<ID, Value> : Exception
{
	/// <summary>
	/// Calls the parent contructor.
	/// </summary>
	public ManagedValueIDAlreadyExists(Manager<ID, Value> manager, ID id)
		: base($"{id.GetType().Name} '{id}' already exists in the '{manager.GetType().Name}' manager.")
	{
	}
}

/// <summary>
/// An abstract class to manage static data initialized lately.
/// Used for scenarios where the objects cannot be instantiated at the beginning
/// of the execution of the program as a static member.
///
/// Under the hood, this class is a wrapper for the Dictionary generic type, but
/// forces the implementation of an "Init" method which should be called to fill
/// the manager with its static data to be later retrieved.
/// </summary>
public abstract class Manager<ID, Value>
{
	/* Properties */

	/// <summary>
	/// Dictionary of all of the managed values.
	/// It is not intended to be accessed directly.
	/// </summary>
	private bool Initialized { get; set; } = false;

	/// <summary>
	/// Dictionary of all of the managed values.
	/// It is not intended to be accessed directly.
	/// </summary>
	private Dictionary<ID, Value> ManagedValues { get; } = new ();

	/* Methods */

	/// <summary>
	/// Initializes the manager, adding all of the "static" data in the
	/// dictionary.
	/// This method can be called only once or will throw an exception.
	/// <exception cref="ManagerAlreadyInitializedException{ID, Value}">
	///		Thrown when this method is called multiple times.
	/// </exception>
	/// </summary>
	public void Init()
	{
		if (Initialized)
			throw new ManagerAlreadyInitializedException<ID, Value>(this);
		Fill();
		Initialized = true;
	}

	/// <summary>
	/// Fills the manager with data.
	/// Is called by the Init method, which can be called only once.
	/// </summary>
	protected abstract void Fill();

	/* Operators */

	/// <summary>
	/// Used to retrieve and set values.
	/// <exception cref="ManagedValueIDAlreadyExists{ID, Value}">
	///		Thrown when trying to insert a value at a key that already exists.
	/// </exception>
	/// </summary>
	public Value this[ID id]
	{
		get => ManagedValues[id];
		set {
			if (ManagedValues.ContainsKey(id))
				throw new ManagedValueIDAlreadyExists<ID, Value>(this, id);
			ManagedValues[id] = value;
		}
	}
}

